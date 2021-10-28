import json


class DT:
    def __init__(self):
        self.cfg_path = '..\\config\\path.json'
        self.cfg = json.load( open(self.cfg_path, 'r') )
        self.dto_path = self.cfg['dto_path']
        #self.dto = json.load( open(self.dto_path) )


    def write(self, obj):
        with open(self.dto_path, 'w') as f:
            f.write( json.dumps(obj, default=lambda o:o.__dict__, sort_keys=True, indent=4) )

